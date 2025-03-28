using System;
using System.Collections.Generic;
using System.Xml;
using Awesomepiece;

public class ResourceFourthYearEventReward : ResourceBase<ResourceFourthYearEventReward>
{
	public class PassReward
	{
		public int day;

		public Reward heartReward;

		public Reward passOnlyReward;
	}

	public class AttendanceReward
	{
		public int day;

		public Reward reward;
	}

	public int maxDay;

	public int requireHeart;

	public List<PassReward> passRewards;

	public List<AttendanceReward> attendanceRewards;

	public override void Init(XmlNode n)
	{
	}

	public PassReward GetPassReward(int day)
	{
		return null;
	}

	public AttendanceReward GetAttendanceReward(int day)
	{
		return null;
	}

	public static void Load(Action callback = null)
	{
	}
}
