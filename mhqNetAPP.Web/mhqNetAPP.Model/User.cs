using System;
namespace mhqNetAPP.Model
{
	/// <summary>user表实体类
	/// 作者:牛腩(QQ:164423073)
	/// 创建时间:2018-05-09 17:54:07
	/// </summary>
	[Serializable]
	public partial class User
	{
		public User()
		{}
		private int _id ;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		private DateTime _creatdate = DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public DateTime creatdate
		{
			set{ _creatdate=value;}
			get{return _creatdate;}
		}
		private string _username ;
		/// <summary>
		/// 
		/// </summary>
		public string username
		{
			set{ _username=value;}
			get{return _username;}
		}
		private string _password ;
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
		}
		private string _face ;
		/// <summary>
		/// 
		/// </summary>
		public string face
		{
			set{ _face=value;}
			get{return _face;}
		}
		private string _usertype ;
		/// <summary>
		/// 
		/// </summary>
		public string usertype
		{
			set{ _usertype=value;}
			get{return _usertype;}
		}
		private string _phone ;
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		private string _qq ;
		/// <summary>
		/// 
		/// </summary>
		public string qq
		{
			set{ _qq=value;}
			get{return _qq;}
		}
		private string _email ;
		/// <summary>
		/// 
		/// </summary>
		public string email
		{
			set{ _email=value;}
			get{return _email;}
		}
		private string _remark ;
		/// <summary>
		/// 
		/// </summary>
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
	}
}
