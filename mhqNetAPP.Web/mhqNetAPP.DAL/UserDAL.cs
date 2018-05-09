using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
namespace mhqNetAPP.DAL
{
    /// <summary>[user]表数据访问类
    /// 作者:牛腩(QQ:164423073)
    /// 创建时间:2018-05-09 17:54:08
    /// </summary>
    public partial class UserDAL
    {
        public UserDAL()
        { }
        /// <summary>增加一条数据
        /// 
        /// </summary>
        public int Add(mhqNetAPP.Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into [user](");
            strSql.Append("[creatdate], [username], [password], [face], [usertype], [phone], [qq], [email], [remark]  )");
            strSql.Append(" values (");
            strSql.Append("@creatdate, @username, @password, @face, @usertype, @phone, @qq, @email, @remark  )");
            strSql.Append(";select @@IDENTITY");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.creatdate == null)
            {
                 h.AddParameter("@creatdate", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@creatdate", model.creatdate);
            }
            if (model.username == null)
            {
                 h.AddParameter("@username", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@username", model.username);
            }
            if (model.password == null)
            {
                 h.AddParameter("@password", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@password", model.password);
            }
            if (model.face == null)
            {
                 h.AddParameter("@face", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@face", model.face);
            }
            if (model.usertype == null)
            {
                 h.AddParameter("@usertype", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@usertype", model.usertype);
            }
            if (model.phone == null)
            {
                 h.AddParameter("@phone", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@phone", model.phone);
            }
            if (model.qq == null)
            {
                 h.AddParameter("@qq", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@qq", model.qq);
            }
            if (model.email == null)
            {
                 h.AddParameter("@email", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@email", model.email);
            }
            if (model.remark == null)
            {
                 h.AddParameter("@remark", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@remark", model.remark);
            }

            int result;
            string obj = h.ExecuteScalar();
            if (!int.TryParse(obj, out result))
            {
                return 0;
            }
            return result;
        }

        /// <summary>更新一条数据
        /// 
        /// </summary>
        public bool Update(mhqNetAPP.Model.User model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [user] set ");
            strSql.Append("[creatdate]=@creatdate, [username]=@username, [password]=@password, [face]=@face, [usertype]=@usertype, [phone]=@phone, [qq]=@qq, [email]=@email, [remark]=@remark  ");
            strSql.Append(" where id=@id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (model.id == null)
            {
                 h.AddParameter("@id", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@id", model.id);
            }
            if (model.creatdate == null)
            {
                 h.AddParameter("@creatdate", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@creatdate", model.creatdate);
            }
            if (model.username == null)
            {
                 h.AddParameter("@username", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@username", model.username);
            }
            if (model.password == null)
            {
                 h.AddParameter("@password", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@password", model.password);
            }
            if (model.face == null)
            {
                 h.AddParameter("@face", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@face", model.face);
            }
            if (model.usertype == null)
            {
                 h.AddParameter("@usertype", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@usertype", model.usertype);
            }
            if (model.phone == null)
            {
                 h.AddParameter("@phone", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@phone", model.phone);
            }
            if (model.qq == null)
            {
                 h.AddParameter("@qq", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@qq", model.qq);
            }
            if (model.email == null)
            {
                 h.AddParameter("@email", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@email", model.email);
            }
            if (model.remark == null)
            {
                 h.AddParameter("@remark", DBNull.Value);
            }
            else
            {
                 h.AddParameter("@remark", model.remark);
            }

            return h.ExecuteNonQuery();
        }

        /// <summary>按条件更新数据
        /// 
        /// </summary>
        public bool UpdateByCond(string str_set, string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update [user] set "+str_set +" "); 
            strSql.Append(" where "+cond);
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            return h.ExecuteNonQuery();
        }

        /// <summary>删除一条数据
        /// 
        /// </summary>
        public bool Delete(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [user] ");
            strSql.Append(" where id=@id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@id", id);
            return h.ExecuteNonQuery();
        }

        /// <summary>根据条件删除数据
        /// 
        /// </summary>
        public bool DeleteByCond(string cond)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from [user] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            return h.ExecuteNonQuery();
        }
		
        /// <summary>取一个字段的值
        /// 
        /// </summary>
        /// <param name="filed">字段，如sum(je)</param>
        /// <param name="cond">条件，如userid=2</param>
        /// <returns></returns>
        public string GetOneFiled(string filed, string cond)
        {
            string sql = "select " + filed + " from [user]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
            return h.ExecuteScalar();
        }

        /// <summary>得到一个对象实体
        /// 
        /// </summary>
        public mhqNetAPP.Model.User GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * from [user] ");
            strSql.Append(" where id=@id ");
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            h.AddParameter("@id", id);
            mhqNetAPP.Model.User model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }

        /// <summary>根据条件得到一个对象实体
        /// 
        /// </summary>
        public mhqNetAPP.Model.User GetModelByCond(string cond, IDbDataParameter[] paras = null)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from [user] ");
            if (!string.IsNullOrEmpty(cond))
            {
                strSql.Append(" where " + cond);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            if (paras!=null)
            {
                h.AddParameter(paras);
            }
            mhqNetAPP.Model.User model = null;
            using (IDataReader dataReader = h.ExecuteReader())
            {
                if (dataReader.Read())
                {
                    model = ReaderBind(dataReader);
                }
                h.CloseConn();
            }
            return model;
        }

        /// <summary>获得数据列表
        /// 
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [user] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
            DataTable dt = h.ExecuteQuery();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>分页获取数据列表
        /// 
        /// </summary>
        public DataSet GetList(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere)
        {
            MSSQLHelper h = new MSSQLHelper();
            h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[user]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);
            DataTable dt = h.ExecuteQuery();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);
            return ds;
        }

        /// <summary>获得数据列表（比DataSet效率高，推荐使用）
        /// 
        /// </summary>
        public List<mhqNetAPP.Model.User> GetListArray(string strWhere, IDbDataParameter[] paras = null)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select * ");
            strSql.Append(" FROM [user] ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            List<mhqNetAPP.Model.User> list = new List<mhqNetAPP.Model.User>();
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(strSql.ToString());
			if (paras!=null)
            {
                h.AddParameter(paras);
            }
            using (IDataReader dataReader = h.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    list.Add(ReaderBind(dataReader));
                }
                h.CloseConn();
            }
            return list;
        }

        /// <summary>分页获取数据列表
        /// 
        /// </summary>
        public List<mhqNetAPP.Model.User> GetListArray(string fileds, string order, string ordertype, int PageSize, int PageIndex, string strWhere, IDbDataParameter[] paras = null)
        {
		  string cond = string.IsNullOrEmpty(strWhere) ? "" : $" where {strWhere}";
            string sql = $"SELECT * FROM ( SELECT ROW_NUMBER() OVER (ORDER BY {order} {ordertype}) AS pos, {fileds} FROM  [user] {cond}  ) AS sp WHERE pos BETWEEN {(((PageIndex - 1) * PageSize) + 1)} AND {PageSize * PageIndex}";
          
            MSSQLHelper h = new MSSQLHelper();
			h.CreateCommand(sql);
            if (paras != null)
            {
                h.AddParameter(paras);
            } 

           /* h.CreateStoredCommand("[proc_SplitPage]");
            h.AddParameter("@tblName", "[user]");
            h.AddParameter("@strFields", fileds);
            h.AddParameter("@strOrder", order);
            h.AddParameter("@strOrderType", ordertype);
            h.AddParameter("@PageSize", PageSize);
            h.AddParameter("@PageIndex", PageIndex);
            h.AddParameter("@strWhere", strWhere);*/

            List<mhqNetAPP.Model.User> list = new List<mhqNetAPP.Model.User>();
            using (IDataReader dataReader = h.ExecuteReader())
            {
                while (dataReader.Read())
                {
                    list.Add(ReaderBind(dataReader));
                }
                h.CloseConn();
            }
            return list;
        }

        /// <summary>对象实体绑定数据
        /// 
        /// </summary>
        public mhqNetAPP.Model.User ReaderBind(IDataReader dataReader)
        {
            mhqNetAPP.Model.User model = new mhqNetAPP.Model.User();
            object ojb;
            ojb = dataReader["id"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.id = int.Parse(ojb.ToString());
            }
            ojb = dataReader["creatdate"];
            if (ojb != null && ojb != DBNull.Value)
            {
                model.creatdate = DateTime.Parse(ojb.ToString());
            }
            model.username = dataReader["username"].ToString();
            model.password = dataReader["password"].ToString();
            model.face = dataReader["face"].ToString();
            model.usertype = dataReader["usertype"].ToString();
            model.phone = dataReader["phone"].ToString();
            model.qq = dataReader["qq"].ToString();
            model.email = dataReader["email"].ToString();
            model.remark = dataReader["remark"].ToString();

            return model;
        }

        /// <summary>计算记录数
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public int CalcCount(string cond, IDbDataParameter[] paras = null)
        {
            string sql = "select count(1) from [user]";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where " + cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
			if (paras!=null)
            {
                h.AddParameter(paras);
            }
            return int.Parse(h.ExecuteScalar());
        }

         /// <summary>取distinct的datatable
        /// 
        /// </summary>
        /// <param name="fileds">字段</param>
        /// <param name="cond">条件</param>
        /// <returns></returns>
        public DataTable GetDistinctTable(string fileds, string cond) {
            string sql = "select distinct "+fileds+" from [user] ";
            if (!string.IsNullOrEmpty(cond))
            {
                sql += " where "+cond;
            }
            MSSQLHelper h = new MSSQLHelper();
            h.CreateCommand(sql);
            return h.ExecuteQuery();
        }
    }
}

