using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PresenterData.Models
{
    public class Presenter
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Presenter's Name")]
        public string StudentName { get; set; }
               
        
        public string SessionId { get; set; }

        [Required]
        [Display(Name = "Paper Title")]
        public string PaperTitle { get; set; }

        [Required]
        [Display(Name = "Paper ID")]
        public int PaperId { get; set; }

        public IEnumerable<Clarity> claritys { get; set; }
        [Display(Name = "Clearity")]
        [Range(1, 5)]
        public int SelectedClarity { get; set; }


        public IEnumerable<Eyecon> eyecons { get; set; }
        [Display(Name = "Eye Contact")]
        [Range(1, 5)]
        public int SelectedEyecon { get; set; }


        public IEnumerable<Inteng> intengs { get; set; }
        [Display(Name = "Interesting")]
        [Range(1, 5)]
        public int SelectedInteng { get; set; }


        public IEnumerable<Timekee> timekees { get; set; }
        [Display(Name = "Timing")]
        [Range(1, 5)]
        public int SelectedTimekee { get; set; }



        public IEnumerable<Origqua> origquas { get; set; }
        [Display(Name = "Originality")]
        [Range(1, 5)]
        public int SelectedOrigqua { get; set; }


        public IEnumerable<Corlev> corlevs { get; set; }
        [Display(Name = "Correctness")]
        [Range(1, 5)]
        public int SelectedCorlev { get; set; }


        public IEnumerable<Wellstru> wellsturs { get; set; }
        [Display(Name = "Structure")]
        [Range(1, 5)]
        public int SelectedWellstru { get; set; }


        public IEnumerable<Gooduse> gooduses { get; set; }
        [Display(Name = "Visuals")]
        [Range(1, 5)]
        public int SelectedGooduse { get; set; }



        public IEnumerable<Questwell> questwells { get; set; }
        [Display(Name = "Understanding")]
        [Range(1, 5)]
        public int SelectedQuestwell { get; set; }


        public IEnumerable<Clearansw> clearansws { get; set; }
        [Display(Name = "Answers")]
        [Range(1, 5)]
        public int SelectedClearansw { get; set; }



        [Display(Name = "Total mark")]
        public string Totmar { get; set; }

        [Display(Name = "BPA")]
        public bool Nominate { get; set; }

        [Display(Name = "Marked")]
        public bool NMarked { get; set; }

        [Display(Name = "Comments")]
        public string Comments { get; set; }

    }
}