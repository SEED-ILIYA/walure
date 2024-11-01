//Dictionary
Dictionary<string, int> infodetails  = new Dictionary<string, int>();
infodetails.Add("John", 89);
infodetails.Add("Ben", 59);
infodetails.Add("Serah", 9);
infodetails.Add("Todd", 8);
infodetails.Add("Ken", 91);
infodetails.Add("grace", 19);
infodetails.Add("Shola", 29);


foreach(var info in infodetails)
{
    Console.WriteLine("key: {0}, Value:{1}",info.Key, info.Value);
}