namespace ConsoleApp1
{
    class Progrma
    {
        static void Main(string[] args)
        {

            Console.WriteLine("started");

            #region task1
            Events events = new Events();
            Event_image eventCheckHardware = new Event_image(Event_Type.Hardware, Level.Information, "Checks hardware");
            Event_image eventCheckFirmware = new Event_image(Event_Type.System, Level.Information, "Checks firmware");

            events.events_list.Add(eventCheckFirmware);
            events.events_list.Add(eventCheckHardware);
            List<IEvent> filtered = events.Filter("Hardware", "Information");
            foreach (var e in filtered)
            {
                Console.WriteLine(e.ToString());
            }
            #endregion

            #region task2
            Diction dic = new Diction();
            dic.translations.Add(new Words(Language.Czech, "Hrbitov", "Pohrebiste"), new Words(Language.English, "Cemetry", "Churchyard", "Graveyard"));
            dic.translations.Add(new Words(Language.Czech, "Skola"), new Words(Language.English, "School"));

            Console.WriteLine(dic.ToString());
            Console.WriteLine(dic.findTranslation("Hrbitov"));
            Console.WriteLine(dic.findTranslation("School"));
            #endregion

        }
    }
}