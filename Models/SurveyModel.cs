#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;

namespace dojo_survey_validation.Models;

public class DojoSurvey
{
    [Required(ErrorMessage ="Please enter a valid name")]
    public string name {get;set;}
    public string location {get;set;}
    public string language {get;set;}
    [Required(ErrorMessage ="Please enter a comment")]
    public string comment {get;set;}
}