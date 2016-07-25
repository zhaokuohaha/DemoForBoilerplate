using Abp.Domain.Entities;
using System;

namespace DemoForBoilerplate.Students
{
	public class GaussianRNG
	{
		/// <summary>
		/// 正态分布随机数
		/// </summary>
		const int N = 100;
		const int MAX = 50;
		const double MIN = 0.1;
		const int MIU = 40;
		const int SIGMA = 1;
		static Random aa = new Random((int)(DateTime.Now.Ticks / 10000));
		public double AverageRandom(double min, double max)//产生(min,max)之间均匀分布的随机数
		{
			int MINnteger = (int)(min * 10000);
			int MAXnteger = (int)(max * 10000);
			int resultInteger = aa.Next(MINnteger, MAXnteger);
			return resultInteger / 10000.0;
		}
		public double Normal(double x, double miu, double sigma) //正态分布概率密度函数
		{
			return 1.0 / (x * Math.Sqrt(2 * Math.PI) * sigma) * Math.Exp(-1 * (Math.Log(x) - miu) * (Math.Log(x) - miu) / (2 * sigma * sigma));
		}
		public double Random_Normal(double miu, double sigma, double min, double max)//产生正态分布随机数
		{
			double x;
			double dScope;
			double y;
			do
			{
				x = AverageRandom(min, max);
				y = Normal(x, miu, sigma);
				dScope = AverageRandom(0, Normal(miu, miu, sigma));
			} while (dScope > y);
			return x;
		}
	}

	public class Student : Entity
	{
		/// <summary>
		/// 分数
		/// </summary>
		public double score { get; set; }
		/// <summary>
		/// 性别
		/// </summary>
		public Sex sex { get; set; }
		/// <summary>
		/// 生源地
		/// </summary>
		public Origin origin { get; set; }

		public Student()
		{
			Random rand = new Random();
			score = rand.Next(0, 101);
			sex = (Sex)rand.Next(0, 2);
			origin = (Origin)rand.Next(0, 34);
		}

		public Student(GaussianRNG rand)
		{
			score = (int)(rand.Random_Normal(60,0.5,0,100));
			sex = (Sex)(rand.Random_Normal(0.5,0.5,0,2));
			origin = (Origin)(rand.Random_Normal(20,0.5,0,33));
		}
	}
}
