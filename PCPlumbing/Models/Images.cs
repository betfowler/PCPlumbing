using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using FluentValidation;
using FluentValidation.Attributes;


namespace PCPlumbing.Models
{
    [Validator(typeof(ImageValidator))]
    public class Images
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Photo")]
        public string Image { get; set; }
        [Display(Name = "Title")]
        public string ImageName { get; set; }
        [Display(Name = "Description")]
        public string ImageDescription { get; set; }
    }

    public class ImageValidator : AbstractValidator<Images>
    {
        public ImageValidator()
        {
            RuleFor(im => im.ImageName).Must(title => title.Length < 20).WithMessage("Image name too long");
        }

    }
}