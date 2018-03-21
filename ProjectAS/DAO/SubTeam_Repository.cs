using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SubTeam_Repository
    {
        private static SubTeam_Repository instance;

        public static SubTeam_Repository Instance
        {
            get { if (instance == null) instance = new SubTeam_Repository(); return instance; }
            private set { instance = value; }
        }

        private SubTeam_Repository() { }

        /// <summary>
        /// Get list Subteam from db
        /// </summary>
        /// <returns></returns>
        public List<SubTeam_Model> GetSubTeamList()
        {
            List<SubTeam_Model> list = new List<SubTeam_Model>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.table_SubTeam");

            foreach (DataRow item in data.Rows)
            {
                SubTeam_Model subTeam = new SubTeam_Model(item);

                list.Add(subTeam);
            }

            return list;
        }

        /// <summary>
        /// Add a Subteam into db
        /// </summary>
        /// <param name="subTeam"></param>
        /// <returns></returns>
        public bool InsertSubTeam(SubTeam_Model subTeam)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("INSERT INTO dbo.table_SubTeam " +
                "VALUES ('" + subTeam.ID + "','" + subTeam.NameDisplay + "','" + subTeam.Info + "')");
            return result > 0;
        }

        /// <summary>
        /// Update a SubTeam by ID
        /// </summary>
        /// <param name="subTeam"></param>
        /// <returns></returns>
        public bool UpdateSubTeamByID(SubTeam_Model subTeam)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.table_SubTeam " +
                "SET NameDisplay = '" + subTeam.NameDisplay + "', Info = '" + subTeam.Info + "' " +
                "WHERE ID = '" + subTeam.ID + "'");
            return result > 0;
        }

        /// <summary>
        /// Delete a SubTeam by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteSubTeamByID(string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.table_SubTeam " +
                " WHERE ID = '"+ id +"'");
            return result > 0;
        }

    }
}
