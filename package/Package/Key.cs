
namespace package
{
	public class Keys
	{
		public int KEY_1 = -1466731422;
		public int KEY_2 = -240896429;
		public int ASIG_1 = -33685778;
		public int ASIG_2 = -267534609;
		public int FSIG_1 = 1305093103;
		public int FSIG_2 = 1453361591;

		public static Keys SetKeys(string GameMode)
		{
			Keys keys = new Keys();
			if (GameMode == "-pw" || GameMode == "-jw")
			{
				keys.KEY_1 = -1466731422;
				keys.KEY_2 = -240896429;
				keys.ASIG_1 = -33685778;
				keys.ASIG_2 = -267534609;
			}
			else if (GameMode == "-fw")
			{
				keys.KEY_1 = 566434367;
				keys.KEY_2 = 408690725;
				keys.ASIG_1 = -1526153788;
				keys.ASIG_2 = -2060097592;
			}
			else if (GameMode == "-eso")
			{
				keys.KEY_1 = -1228069623;
				keys.KEY_2 = 1822409141;
				keys.ASIG_1 = 1571301968;
				keys.ASIG_2 = 2043846474;
			}
			else if (GameMode == "-rwpd")
			{
				keys.KEY_1 = 711164174;
				keys.KEY_2 = 839959661;
				keys.ASIG_1 = -1424846705;
				keys.ASIG_2 = -1289545470;
			}
			return keys;
		}
	}
}
