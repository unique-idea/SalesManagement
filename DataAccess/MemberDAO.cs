using BusinessObject;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MemberDAO:DBConnection
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO() { }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        // GET MEMBER BY ID
        public MemberObject GetUserWithID(int userId)
        {
            IDataReader dataReader = null;
            MemberObject user = null;
            string SQLSelect = "SELECT MemberId, Email, CompanyName, City, Country, Password FROM Members WHERE MemberId = @UserId";
            try
            {
                var param = DataProvider.CreateParameter("@UserId", 4, userId, DbType.Int32);
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    user = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return user;
        }

        // GET A MEMBER FROM TABLE "Member"
        public List<MemberObject> GetUsers()
        {
            string SQLSelect = "SELECT MemberId, Email, CompanyName, City, Country, Password FROM Members";
            var users = new List<MemberObject>();
            IDataReader dataReader = null;
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    users.Add(new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return users;
        }

        // GET MEMBER ID FROM TABLE "Member"
        public List<string> GetUsersID()
        {
            string SQLSelect = "SELECT MemberId FROM Members";
            var usersID = new List<string>();
            IDataReader dataReader = null;
            try
            {
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    usersID.Add(dataReader.GetInt32(0).ToString());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return usersID;
        }

        // CREATE A MEMBER (OR A USER)
        public void Create(MemberObject user)
        {
            try
            {
                MemberObject userByID = GetUserWithID(user.MemberId);
                if (userByID == null)
                {
                    string SQLInsert = "INSERT Members VALUES(@UserId, @Email, @CompanyName, @City, @Country, @Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@UserId", 4, user.MemberId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@Email", 100, user.Email, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@CompanyName", 40, user.CompanyName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@City", 15, user.City, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Country", 15, user.Country, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Password", 30, user.Password, DbType.String));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This user has already existed");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        // DELETE A MEMBER (OR A USER)
        public void Delete(int userID)
        {
            try
            {
                MemberObject member = GetUserWithID(userID);
                if (member != null)
                {
                    string SQLDelete = "DELETE Members WHERE MemberId = @UserId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@UserId", 4, userID, DbType.Int32));
                    DataProvider.Update(SQLDelete, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("This user does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

        }
        // UPDATE A MEMBER (OR A USER)
        public void Update(MemberObject user)
        {
            try
            {
                MemberObject userById = GetUserWithID(user.MemberId);
                if (userById != null)
                {
                    string SQLInsert = "UPDATE Members SET MemberId = @UserId, Email = @Email, CompanyName = @CompanyName, City = @City, Country = @Country, Password = @Password WHERE MemberId = @UserId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(DataProvider.CreateParameter("@UserId", 4, user.MemberId, DbType.Int32));
                    parameters.Add(DataProvider.CreateParameter("@Email", 100, user.Email, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@CompanyName", 40, user.CompanyName, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@City", 15, user.City, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Country", 15, user.Country, DbType.String));
                    parameters.Add(DataProvider.CreateParameter("@Password", 30, user.Password, DbType.String));
                    DataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("Updating user has been error");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        // USE THIS TO CHECK THE LOGIN STATUS
        public MemberObject Login(string email, string password)
        {
            IDataReader dataReader = null;
            MemberObject user = null;
            try
            {
                string SQLSelect = "SELECT MemberId, Email, CompanyName, City, Country, Password FROM Members WHERE Email = @Email AND Password = @Password";
                var parameters = new List<SqlParameter>();
                parameters.Add(DataProvider.CreateParameter("@Email", 100, email, DbType.String));
                parameters.Add(DataProvider.CreateParameter("@Password", 30, password, DbType.String));
                dataReader = DataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());

                if (dataReader.Read())
                {
                    user = new MemberObject
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            return user;
        }
    }
}
