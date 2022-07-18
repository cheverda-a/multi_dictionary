using Dapper;
using Multilingo.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Multilingo.SQL
{
    public class TopicsAccessor 
    {
        private static string sqlConnection = @"Server=NASTYA-ASUS\SQLEXPRESS;Database=DictionaryDatabase;Trusted_Connection=True;";
        public Topic GetTopicById(int id)
        {
            Topic topic = new Topic();
            using (var connection = new SqlConnection(sqlConnection))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Topics] WHERE Id = @Id";
                topic = connection.Query<Topic>(selectQuery, new { id }).FirstOrDefault();
            }
            return topic;
        }
        public List<Topic> GetTopics()
        {
            List<Topic> topics = new List<Topic>();
            using (var connection = new SqlConnection(sqlConnection))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Topics]";
                topics = connection.Query<Topic>(selectQuery).ToList();
            }
            return topics;
        }
        public int GetTopicId(Topic topic)
        {
            var id = 0;
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"SELECT [Id] FROM [dbo].[Topics] WHERE Name = @Name";
                id = connection.Query<int>(insertQuery, new { topic.Name, topic.Id }).FirstOrDefault();
            }
            return id;
        }

        public int CreateTopic(Topic topic)
        {
            var id = 0;
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"INSERT INTO[dbo].[Topics]([Name]) OUTPUT INSERTED.Id VALUES(@Name)";
                id = connection.QuerySingle<int>(insertQuery, new { topic.Name });
            }
            return id;
        }

        public void DeleteTopic(int id)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string deleteQuery = @"DELETE FROM [dbo].[Topics] WHERE Id = @Id";
                connection.Execute(deleteQuery, new { id });
            }
        }

        public void EditTopic(Topic topic)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string updateQuery = @"UPDATE [dbo].[Topics] SET Name = @Name WHERE Id = @Id";
                connection.Execute(updateQuery, new { topic.Name, topic.Id });
            }
        }

        public int TopicCount()
        {
            int count = 0;
            using (var connection = new SqlConnection(sqlConnection))
            {
                string selectQuery = @"SELECT COUNT(*) FROM [dbo].[Topics]";
                count = (Int32)connection.ExecuteScalar(selectQuery);
            }
            return count;
        }

        public int TermsCount(int id)
        {
            int count;
            using (var connection = new SqlConnection(sqlConnection))
            {
                string selectQuery = @"SELECT COUNT(*) FROM [dbo].[Terms] WHERE TopicId = @id";
                count = (Int32)connection.ExecuteScalar(selectQuery, new { id });
            }
            return count;
        }
    }
}
