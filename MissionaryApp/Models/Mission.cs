﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MissionaryApp.Models
{
    public class Mission
    {
        public string MissionName { get; set; }
        public string President { get; set; }
        public string Address { get; set; }
        public string Language { get; set; }
        public string Climate { get; set; }
        public string DominantReligion { get; set; }
        public string LogoFilePath { get; set; }
        public List<string> QuestionsList { get; set; }
        public List<string> AnswerList { get; set; }

        public Mission(string missionName, string president, string address, string language, string climate, string dominantReligion, string logoFilePath)
        {
            this.MissionName = missionName;
            this.President = president;
            this.Address = address;
            this.Language = language;
            this.Climate = climate;
            this.DominantReligion = dominantReligion;
            this.LogoFilePath = logoFilePath;

            this.QuestionsList = new List<string>();
            QuestionsList.Add("Do I really need two suits?");
            QuestionsList.Add("How much does it rain there?");
            QuestionsList.Add("Is the food pretty nasty?");
            QuestionsList.Add("Does the mission president allow backpacks?");
            QuestionsList.Add("Do they have supermarkets there?");

            this.AnswerList = new List<string>();
            AnswerList.Add("No way, Jose.");
            AnswerList.Add("This |_______________| much.");
            AnswerList.Add("Nope. Nope. Nope. Nope.");
            AnswerList.Add("Check the missionary handbook, bro (or sis).");
            AnswerList.Add("Of course.");
        }
    }
}