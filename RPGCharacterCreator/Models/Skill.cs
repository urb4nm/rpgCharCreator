﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace RPGCharacterCreator.Models
{
    public class Skill
    {
        public Skill()
        {
            ClassRequiredChoices = new SelectList(new string[] { "Mage", "Knight", "Rouge" });
            SkillTypeChoices = new SelectList(new string[] { "Offensive", "Defensive", "Neutral" });
            this.CharacterSkill = new HashSet<CharacterSkill>();
        }

        [Key]
        [Display(Name="Skill Id")]
        public int Id { get; set; }

        [Required]
        [Display(Name="Skill Name")]
        public string SkillName { get; set; }

        [Required]
        [Display(Name = "Class Required")]
        public string ClassRequired { get; set; }

        public SelectList ClassRequiredChoices { get; set; }

        [Required]
        [Display(Name= "Skill Type")]
        public string SkillType { get; set; }

        public SelectList SkillTypeChoices { get; set; }

        [Required]
        [Display(Name= "Skill Level")]
        [Range(1,3, ErrorMessage="Out of skill level")]
        public int SkillLevel { get; set; }

        public ICollection<CharacterSkill> CharacterSkill { get; set; }
    }
}
