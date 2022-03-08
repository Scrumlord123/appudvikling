using System;
using System.Collections.Generic;

namespace Modul004
{
    public class Deck_of_Cards
    {

        //defining members
        private Stack<card> _cards = new Stack<card>();



        // constructor
        public Deck_of_Cards()
        {
            int index = 0;
            for (int i = 2; i <= 14; i++)
            {

                card spar = new card("spar", i);
                _cards.Push(spar);
                index++;
                {
                    card klør = new card("klør", i);
                    _cards.Push(klør);
                    index++;
                    {
                        card hjerter = new card("hjerter", i);
                        _cards.Push(hjerter);
                        index++;
                        {
                            card ruder = new card("ruder", i);
                            _cards.Push(ruder);
                            index++;

                        }

                        // Method

                        {

                        }
                    }
                }
            }
        }
    }
}