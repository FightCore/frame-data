namespace FightCore.Enricher
{
    // This entire class is based on scanning local files and applying the patterns on the remote stored files.
    // I would scan the files through web but this isn't really possible.
	public class AlternativeAnimationFinder
	{
		private readonly string _localDirectory;

        public AlternativeAnimationFinder(string localDirectory = "C:/tmp/pngs")
        {
            _localDirectory = localDirectory;
        }

        public List<string> Get(string character, string move)
        {
            var folder = Path.Combine(_localDirectory, character);
            var alternativeGifs = Directory.GetFiles(folder, $"{move}_*.png").Select(Path.GetFileNameWithoutExtension);
            return alternativeGifs.ToList();
		}
    }
}
