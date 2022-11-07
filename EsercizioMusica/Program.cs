using System;
using System.Media;
using System.ComponentModel;
using System.Numerics;
using static EsercizioMusica.Program;

namespace EsercizioMusica
{
    class Program
    {
        private static Iplayer iplayer;

        static void Main(string[] args)

        { 

            StreamingPlatform streaming = new StreamingPlatform();
            //while (true)
            //{


            Console.Write("Choose your option: ");
            var num = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("1. Add Music");
                Console.WriteLine("2. Play Music");
                Console.WriteLine("3. Search Music");
                Console.WriteLine("4. List of the all Music ");
                Console.WriteLine("0. exit");
                Console.WriteLine();

                Console.Write("Choose your option: ");
                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        
                        Console.WriteLine("Aggiungi musica");

                        Song song = new Song();

                        Console.WriteLine("inserisci il titolo");
                        song._titolo= Console.ReadLine();

                        Console.WriteLine("inserisci votoda 1 a 10");
                        song._rate = int.Parse(Console.ReadLine());


                    streaming.Addmusic(song);

                    break;

                    case 2:
                        Console.WriteLine("Hai scelto play");

                        Console.WriteLine("Hai avviato la canzone");



                    break;

                    case 3:
                        Console.WriteLine("Search Music");
                        

                        
                        break;

                    case 4:
                        Console.WriteLine("List of the all Music");
                        streaming.print();
                    
                        
                        break;

                    case 0:
                        
                        return;
                        
                }

            }while ( num != 0);



        }

        public class StreamingPlatform
        {
            public string name;
            

            Song[] _Music = new Song[1000];

            public void Addmusic(Song song)
            {

                for (int i = 0; i < _Music.Length; i++) {


                    

                    if (_Music[i] == null)
                    {
                        _Music[i] = song;
                        break;
                    }

                    

                }
            }


            public void print()
            {
                for (int i = 0; i < _Music.Length; i++)
                {

                    Console.WriteLine("\n Titolo Canzone :",_Music );
                }
            }



            public void searchMusic()
            {
                for (int i = 0; i < _Music.Length; i++)
                {

                    
                        
                        Console.WriteLine("\n Titolo Canzone :", _Music);

                    
                    
                }
            }
        }



        public class Song : StreamingPlatform
        {
            
            
            public string _titolo;
            public bool  _state;
            public int _rate;

            public Song() {

               

            }
            


            
        }






        interface IPlayer
        {
            public void Play(int SongId);
            public void ShowPlaying();
            public void StartPlaying();
            public void Stop();
            public void Pause();
            public void Rate();
            public void Forward();
            public void Backward();
            public void ListSongs();

        }
        public interface Iplayer
        {
            void play();
            void pause();

            void rate();
            void forward();
            void backward();
        }


    }





}

        

    







  
