using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MfxMovieReview.Models;

public class MostPopularData
{
    public List<MostPopularDataDetail> Items { get; set; }

    public string ErrorMessage { get; set; }
}

public class MostPopularDataDetail
{
    public string Id { get; set; }
    public string Rank { get; set; }
    public string RankUpDown { get; set; }
    public string Title { set; get; }
    [Display(Name = "Title")]
    public string FullTitle { set; get; }
    public string Year { set; get; }
    public string Image { get; set; }
    public string Crew { get; set; }
    [Display(Name = "IMDb Rating")]
    public string IMDbRating { get; set; }
    [Display(Name = "Rating Count")]
    public string IMDbRatingCount { get; set; }
}
