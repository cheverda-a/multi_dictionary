using Dapper;
using Multilingo.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Multilingo.SQL
{
    public class TermsAccessor 
    {
        private static string sqlConnection = @"Server=NASTYA-ASUS\SQLEXPRESS;Database=DictionaryDatabase;Trusted_Connection=True;";

        public int GetTopicId(Term term)
        {
            var id = 0;
            using (var connection = new SqlConnection(sqlConnection))
            {   
                string insertQuery = @"SELECT [TopicId] FROM [dbo].[Terms] WHERE Id = @Id";
                id = connection.Query<int>(insertQuery, new { term.TopicId, term.Id }).FirstOrDefault();
            }
            return id;
        }

        public int GetIdEn(Term term)
        {
            var id = 0;
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"SELECT [Id] FROM [dbo].[Terms] WHERE TermEn = @TermEn";
                id = connection.Query<int>(insertQuery, new { term.TermEn, term.Id }).FirstOrDefault();
            }
            return id;
        }

        public int GetIdFr(Term term)
        {
            var id = 0;
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"SELECT [Id] FROM [dbo].[Terms] WHERE TermFr = @TermFr";
                id = connection.Query<int>(insertQuery, new { term.TermFr, term.Id }).FirstOrDefault();
            }
            return id;
        }

        public int GetIdUa(Term term)
        {
            var id = 0;
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"SELECT [Id] FROM [dbo].[Terms] WHERE TermUa = @TermUa";
                id = connection.Query<int>(insertQuery, new { term.TermUa, term.Id }).FirstOrDefault();
            }
            return id;
        }

        public void CreateUa(Term term)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"INSERT INTO [dbo].[Terms](TermUa, DefinitionUa, TopicId) VALUES(@TermUa, @DefinitionUa, @TopicId)";
                connection.Execute(insertQuery,
                new
                {
                    term.TermUa,
                    term.DefinitionUa,
                    term.TopicId
                });
            }
        }

        public void CreateEn(Term term)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"INSERT INTO [dbo].[Terms](TermEn, DefinitionEn, TopicId) VALUES(@TermEn, @DefinitionEn, @TopicId)";
                connection.Execute(insertQuery,
                new
                {
                    term.TermEn,
                    term.DefinitionEn,
                    term.TopicId
                });
            }
        }

        public void CreateFr(Term term)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string insertQuery = @"INSERT INTO [dbo].[Terms](TermFr, DefinitionFr, TopicId) VALUES(@TermFr, @DefinitionFr, @TopicId)";
                connection.Execute(insertQuery,
                new
                {
                    term.TermFr,
                    term.DefinitionFr,
                    term.TopicId
                });
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string deleteQuery = @"DELETE FROM [dbo].[Terms] WHERE Id = @Id";
                connection.Execute(deleteQuery, new { id });
            }
        }

        public void EditUa(Term term)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string updateQuery = @"UPDATE [dbo].[Terms] SET TermUa = @TermUa, DefinitionUa = @DefinitionUa WHERE Id = @Id";
                var result = connection.Execute(updateQuery, new
                {
                    term.TermUa,
                    term.DefinitionUa,
                    term.Id
                });
            }
        }

        public void EditEn(Term term)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string updateQuery = @"UPDATE [dbo].[Terms] SET TermEn = @TermEn, DefinitionEn = @DefinitionEn WHERE Id = @Id";
                var result = connection.Execute(updateQuery, new
                {
                    term.TermEn,
                    term.DefinitionEn,
                    term.Id
                });
            }
        }       
        
        public void EditFr(Term term)
        {
            using (var connection = new SqlConnection(sqlConnection))
            {
                string updateQuery = @"UPDATE [dbo].[Terms] SET TermFr = @TermFr, DefinitionFr = @DefinitionFr WHERE Id = @Id";
                var result = connection.Execute(updateQuery, new
                {
                    term.TermFr,
                    term.DefinitionFr,
                    term.Id
                });
            }
        }

        public Term GetTermById(int id)
        {
            Term term = new Term();
            using (var connection = new SqlConnection(sqlConnection))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Terms] WHERE Id = @Id";
                term = connection.Query<Term>(selectQuery, new { id }).FirstOrDefault();
            }
            return term;
        }

        public List<Term> GetTermsFromTopic(int id)
        {
            List<Term> terms = new List<Term>();
            using (var connection = new SqlConnection(sqlConnection))
            {
                string selectQuery = @"SELECT * FROM [dbo].[Terms] WHERE TopicId = @id";
                terms = connection.Query<Term>(selectQuery, new { id }).ToList();
            }
            return terms;
        }
    }
}
