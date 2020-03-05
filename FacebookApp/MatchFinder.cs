using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace C19_Ex01_Maayan_313353161_Eden_315855049
{
    public class MatchFinder
    {
        private const int           k_StartYearSubStringIndex = 6;
        private const int           k_MaxAgeRange = 120;
        private User                m_LoggedInUser;
       
        public MatchFinder(User i_LoggedInUser)
        {
            this.SelectedGender = new Dictionary<string, bool>();
            this.m_LoggedInUser = i_LoggedInUser;
        }

        public string AgeRangeSelected { get; set; }
        public Dictionary<string, bool> SelectedGender { get; set; }
        public List<User> MatchFriends { get; set; }

        public void FindMatch()
        {
            foreach (User friend in this.m_LoggedInUser.Friends)
            {
               if (this.isInAgeRange(friend))
                {
                    this.MatchFriends.Add(friend);
                }
            }
        }

        private bool isInAgeRange(User i_Friend)
        {
            bool isInRange = false;
            int friendAge = this.parseBirthdayToAge(i_Friend.Birthday);
            int maxAge;
            int minAge;

            this.parseAgeRange(this.AgeRangeSelected, out minAge, out maxAge);
            isInRange = this.isFriendInRange(friendAge, minAge, maxAge);
            return isInRange;
        }

        private void parseAgeRange(string i_AgeRange, out int o_MinAge, out int o_MaxAge)
        {
            int index = 0;
            o_MaxAge = 0;
            o_MinAge = 0;

            while (index < i_AgeRange.Length)
            {
                if (i_AgeRange[index] == '-' || i_AgeRange[index] == '+')
                {
                    o_MinAge = int.Parse(i_AgeRange.Substring(0, index - 1));
                    if (i_AgeRange[index] != '+')
                    {
                        o_MaxAge = int.Parse(i_AgeRange.Substring(index + 1));
                    }
                    else
                    {
                        o_MaxAge = k_MaxAgeRange;
                    }
                    break;
                }
            }
        }

        private bool isFriendInRange(int i_FriendAge, int i_MinAge, int i_MaxAge)
        {
            bool isInRange = false;

            if (i_FriendAge >= i_MinAge && i_FriendAge <= i_MaxAge)
            {
                isInRange = true;
            }
            return isInRange;
        }

        private int parseBirthdayToAge(string i_Birthday)
        {
            int age;
            bool isParseSuccessfull = int.TryParse(i_Birthday.Substring(k_StartYearSubStringIndex), out age);

            if (isParseSuccessfull)
            {
                age =  DateTime.Now.Year - age;
            }
            else
            {
                throw new Exception("Unsuccessfull parse in parseBirthdayToAge method");
            }

            return age;
        }
    }
}
