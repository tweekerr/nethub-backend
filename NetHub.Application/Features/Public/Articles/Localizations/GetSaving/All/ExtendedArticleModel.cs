﻿using NetHub.Data.SqlServer.Entities.Views;
using NetHub.Data.SqlServer.Enums;

namespace NetHub.Application.Features.Public.Articles.Localizations.GetSaving.All;

public record ExtendedArticleModel
{
	public long? UserId { get; set; }
	public bool? IsSaved { get; set; }
	public DateTimeOffset? SavedDate { get; set; }
	public Rating? Vote { get; set; }
	public string Title { get; set; } = default!;
	public string Description { get; set; } = default!;
	public string Html { get; set; } = default!;
	public DateTimeOffset Created { get; set; }
	public DateTimeOffset? Updated { get; set; }
	public int Views { get; set; } = 0;
	public long ArticleId { get; set; }
	public string LanguageCode { get; set; } = default!;
	public long LocalizationId { get; set; }
	public long ContributorId { get; set; }
	public ArticleContributorRole ContributorRole { get; set; }

	// public ArticleContributorModel2[] Contributors { get; set; }
	public int Rate { get; set; }
}