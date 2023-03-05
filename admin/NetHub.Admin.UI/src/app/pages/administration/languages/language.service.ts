import { Injectable, Injector } from '@angular/core';
import { Observable } from 'rxjs';
import { ErrorDto, LanguageModel, LanguagesApi } from '../../../api';
import { FormId } from '../../../components/form/types';
import { IFiltered, IFilterInfo } from '../../../components/table/types';
import { FormServiceBase } from '../../../services/abstractions/form-service-base';
import { ModalsService } from '../../../services/modals.service';
import { LoaderService, ToasterService } from '../../../services/viewport';

@Injectable({ providedIn: 'root' })
export class LanguageService extends FormServiceBase {
  flagFile?: File;
  public lastFormId?: FormId<string>;

  constructor(
    injector: Injector,
    private readonly modals: ModalsService,
    private readonly loader: LoaderService,
    private readonly toaster: ToasterService,
    private readonly languagesApi: LanguagesApi,
  ) {
    super(injector, {
      code: ['', []],
      name: ['', []],
      nameLocal: ['', []],
      flagUrl: [<string | null>null, []],
    });
  }

  showForm(): void {
    this.router.navigate(['languages', this.lastFormId]);
  }

  getByCode(code: string): void {
    this.onRequestStart();
    this.languagesApi.getByCode(code).subscribe({
      next: (lang: LanguageModel | any) => {
        lang.nameLocal = lang.name[code] || '';
        lang.name = lang.name.en;
        this.form.setValue(lang);
        this.onRequestSuccess();
      },
      error: (error: ErrorDto) => {
        this.onRequestError(error);
      },
    });
  }

  filter(request: IFilterInfo): Observable<IFiltered<LanguageModel>> {
    return this.languagesApi.filter(request.filters, request.sorts, request.page, request.pageSize);
  }

  create(): void {
    this.onRequestStart();
    this.languagesApi.create(this.getRequestModel()).subscribe({
      next: (lang: LanguageModel) => {
        this.toaster.showSuccess('Language successfully created');
        this.onRequestSuccess(lang.code);
        this.router.navigate(['languages', lang.code]);
      },
      error: (error: ErrorDto) => {
        this.onRequestError(error);
      },
    });
  }

  update(code: string): void {
    this.onRequestStart();
    this.languagesApi.update(this.getRequestModel(code)).subscribe({
      next: () => {
        this.toaster.showSuccess('Language successfully updated');
        this.onRequestSuccess(code);
      },
      error: (error: ErrorDto) => {
        this.onRequestError(error);
      },
    });
  }

  delete(code: string): void {
    this.modals.showConfirmDelete({
      confirmed: () => {
        this.onRequestStart();
        this.languagesApi.delete(code).subscribe({
          next: () => {
            this.toaster.showSuccess('Language successfully deleted');
            this.router.navigateByUrl('languages');
            this.onRequestSuccess();
          },
          error: (error: ErrorDto) => {
            this.onRequestError(error);
          },
        });
      },
    });
  }

  private uploadFlagFile(code: string): Observable<void> {
    if (!this.flagFile) {
      throw new Error('Flag file is required.');
    }
    // const reader = new FileReader();
    // reader.onload = e => console.log(e);
    // reader.readAsDataURL(this.flagFile);

    return this.languagesApi.uploadFlag(code, {
      data: this.flagFile,
      fileName: this.flagFile.name,
    });
  }

  private getRequestModel(code?: string): LanguageModel {
    const value = this.form.value;
    code = value.code || code;
    return LanguageModel.fromJS({
      code: code!,
      name: {
        en: value.name,
        [code!]: value.nameLocal,
      },
    });
  }

  private onRequestStart() {
    // console.log('request started');
    this.loader.show();
    if (this.isReady) {
      this.setReady('loading');
    }
  }

  private onRequestSuccess(code?: string) {
    // console.log('request succeed');
    this.setReady('ready');
    this.loader.hide();

    if (this.flagFile && code) {
      this.uploadFlagFile(code).subscribe(() => {
        console.log('success!');
        // this.loader.hide();
        // this.form.ready.setValue('ready');
      });
    } else {
    }
  }

  private onRequestError(error: ErrorDto) {
    this.loader.hide();

    if (error.status === 400) {
      this.form.get('code')!.setErrors({
        'api-error': error['errors'].code,
      });
      this.toaster.showFail(error.message);
      this.setReady('ready');
    } else if (error.status === 500) {
      this.toaster.showFail(error['errors'].exception);
      this.setReady('ready');
    } else {
      this.toaster.showFail(error.message);
      this.setReady('404');
    }
  }
}
