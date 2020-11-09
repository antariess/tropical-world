using System;
using Data.Models;

namespace Api.Responses
{
    public class AnimalResponse : AnimalEntity
    {
        public bool isRecent {get; set;}
        public AnimalResponse(string name) :base(name)
        {
            isRecent = checkIsRecent(Added);
        }
        private bool checkIsRecent(DateTime datetime)
        {
            return Added.Month > 10;
        }

    }
}
