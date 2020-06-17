//(c)Rey35
using System.IO;

namespace tasks
{
	public class AWARD_VAR_SCALE
	{
		public int m_ulScales;
		public TASK_EXPRESSION[] AwardVar = TASK_EXPRESSION.New(GlobalData.MAX_AWARD_VAR_SCALES);
		public AWARD_DATA[] m_Awards = new AWARD_DATA[0];

		internal static void Read(int version, BinaryReader br, AWARD_VAR_SCALE AWARD_VAR_SCALE)
		{
			AWARD_VAR_SCALE.m_ulScales = br.ReadInt32();
			for (int i = 0; i < AWARD_VAR_SCALE.AwardVar.Length; i++)
			{
				TASK_EXPRESSION.Read(version, br, AWARD_VAR_SCALE.AwardVar[i]);
			}
			AWARD_VAR_SCALE.m_Awards = new AWARD_DATA[AWARD_VAR_SCALE.m_ulScales];
			for (int i = 0; i < AWARD_VAR_SCALE.m_Awards.Length; i++)
			{
				AWARD_VAR_SCALE.m_Awards[i] = new AWARD_DATA();
				AWARD_DATA.Read(version, br, AWARD_VAR_SCALE.m_Awards[i]);
			}
		}

		internal static void Write(int version, BinaryWriter bw, AWARD_VAR_SCALE AWARD_VAR_SCALE)
		{
			bw.Write(AWARD_VAR_SCALE.m_ulScales);
			for (int i = 0; i < AWARD_VAR_SCALE.AwardVar.Length; i++)
			{
				TASK_EXPRESSION.Write(version, bw, AWARD_VAR_SCALE.AwardVar[i]);
			}
			for (int i = 0; i < AWARD_VAR_SCALE.m_Awards.Length; i++)
			{
				AWARD_DATA.Write(version, bw, AWARD_VAR_SCALE.m_Awards[i]);
			}
		}
	}
}
//(c)Rey35