using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BasketballTeamRegistration.Models
{
    static class TeamRegistrationDB
    {

        /// <summary>
        /// Connect to TeamRegistration database.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = "Data Source=localhost;Initial Catalog=TeamRegistration;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return connection;
        }
        
        /// <summary>
        /// Adds team object to database
        /// </summary>
        /// <param name="newTeam"></param>
        public static void Add(Team newTeam)
        {
            // connection object
            SqlConnection connection = GetConnection();

            // command object
            SqlCommand addCmd = new SqlCommand();
            addCmd.Connection = connection;

            // parameterized query
            addCmd.CommandText = "INSERT INTO Team(TeamName, TeamCaptain, CoachName, Scheme, Playmaker)" +
                                 "VALUES (@teamName, @teamCaptain, @coachName, @scheme, @playmaker)";
            // add values into parameters
            addCmd.Parameters.AddWithValue("@teamName", newTeam.TeamName);
            addCmd.Parameters.AddWithValue("@teamCaptain", newTeam.TeamCaptain);
            addCmd.Parameters.AddWithValue("@coachName", newTeam.CoachName);
            addCmd.Parameters.AddWithValue("@scheme", newTeam.Scheme);
            addCmd.Parameters.AddWithValue("@playmaker", newTeam.Playmaker);

            // open connection
            try
            {
                connection.Open();
                int rowsAffected = addCmd.ExecuteNonQuery();
            }
            finally
            {
                connection.Dispose();
            }

        }
            

        


    }
}
