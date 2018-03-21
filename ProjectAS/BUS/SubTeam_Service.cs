using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class SubTeam_Service
    {
        private static SubTeam_Service instance;

        public static SubTeam_Service Instance
        {
            get { if (instance == null) instance = new SubTeam_Service(); return instance; }
            private set { instance = value; }
        }

        private SubTeam_Service() { }

        /// <summary>
        /// Load list Sub Team
        /// </summary>
        /// <returns></returns>
        public List<SubTeam_Model> LoadSubTeam()
        {
            return SubTeam_Repository.Instance.GetSubTeamList();
        }

        /// <summary>
        /// Add a sub team
        /// </summary>
        /// <param name="subTeam"></param>
        /// <returns></returns>
        public bool AddSubTeam(SubTeam_Model subTeam)
        {
            return SubTeam_Repository.Instance.InsertSubTeam(subTeam);
        }

        /// <summary>
        /// Update a sub team
        /// </summary>
        /// <param name="subTeam"></param>
        /// <returns></returns>
        public bool UpdateSubTeamByID(SubTeam_Model subTeam)
        {
            return SubTeam_Repository.Instance.UpdateSubTeamByID(subTeam);
        }

        /// <summary>
        /// Delete a sub team - WARNING
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool DeleteSubTeamByID(string ID)
        {
            return SubTeam_Repository.Instance.DeleteSubTeamByID(ID);
        }


    }
}
