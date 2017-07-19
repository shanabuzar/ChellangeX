//-----------------------------------------------------------------------
// <copyright file="DataLoaderRepository.cs" company="DevBatch Ltd">
// Copyright (c) DevBatch Ltd. All rights reserved.
// </copyright>
// <summary>DataLoader Repositoryclass.</summary>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace OXo.Repositories.Repositories
{
    /// <summary>
    /// DataLoaderRepository class.
    /// </summary>
    /// <seealso cref="ValuesController" />
    public class DataLoaderRepository
    {
        ChallengeXEntities db;

        public DataLoaderRepository()
        {
            db = new ChallengeXEntities();
        }

        /// <summary>
        /// Crete the  Content_Government
        /// </summary>

        public bool Create(DataSet ds, String themeDDLValue)
        {
            var questionsData = db.QuestionAnswers.Where(a => a.Theme == themeDDLValue).ToList();
            if (questionsData.Count() > 0)
            {
                foreach (var item in questionsData)
                {
                    db.QuestionAnswers.Remove(item);
                    db.SaveChanges();
                }
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    QuestionAnswer objQuestion = new QuestionAnswer
                    {
                        QuestionNo = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()),
                        Question = ds.Tables[0].Rows[i][1].ToString(),
                        OptionA = ds.Tables[0].Rows[i][2].ToString(),
                        OptionB = ds.Tables[0].Rows[i][3].ToString(),
                        OptionC = ds.Tables[0].Rows[i][4].ToString(),
                        Answer = ds.Tables[0].Rows[i][5].ToString(),
                        Level = ds.Tables[0].Rows[i][6].ToString(),
                        Bonus = Convert.ToInt32(ds.Tables[0].Rows[i][7].ToString()),
                        ResponseTime = Convert.ToInt32(ds.Tables[0].Rows[i][8].ToString()),
                        Theme = themeDDLValue
                    };

                    db.QuestionAnswers.Add(objQuestion);
                    db.SaveChanges();
                }
            }
            else
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    QuestionAnswer objQuestion = new QuestionAnswer
                    {
                        QuestionNo = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString()),
                        Question = ds.Tables[0].Rows[i][1].ToString(),
                        OptionA = ds.Tables[0].Rows[i][2].ToString(),
                        OptionB = ds.Tables[0].Rows[i][3].ToString(),
                        OptionC = ds.Tables[0].Rows[i][4].ToString(),
                        Answer = ds.Tables[0].Rows[i][5].ToString(),
                        Level = ds.Tables[0].Rows[i][6].ToString(),
                        Bonus = Convert.ToInt32(ds.Tables[0].Rows[i][7].ToString()),
                        ResponseTime = Convert.ToInt32(ds.Tables[0].Rows[i][8].ToString()),
                        Theme = themeDDLValue
                    };

                    db.QuestionAnswers.Add(objQuestion);
                    db.SaveChanges();
                }
            }

            return true;
        }

        /// <summary>
        /// Get All Content_Government
        /// </summary>
        /// <returns>list of content_government</returns>
        public IEnumerable<QuestionAnswer> GetAll()
        {
            return db.QuestionAnswers.ToList();
        }
    }
}
