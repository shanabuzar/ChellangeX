//-----------------------------------------------------------------------
// <copyright file="DataLoaderService.cs" company="DevBatch Ltd">
// Copyright (c) DevBatch Ltd. All rights reserved.
// </copyright>
// <summary>DataLoader Service class.</summary>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using Oxo.Entities.Modals;
using OXo.Repositories;
using OXo.Repositories.Repositories;

namespace Oxo.Services.Services
{
    /// <summary>
    /// DataLoaderService class.
    /// </summary>
    /// <seealso cref="ValuesController" />
    public class DataLoaderService
    {
        private DataLoaderRepository dataLoaderRepository;

        public DataLoaderService()
        {
            this.dataLoaderRepository = new DataLoaderRepository();
        }

        public DataLoaderService(DataLoaderRepository dataLoaderRepository)
        {
            this.dataLoaderRepository = dataLoaderRepository;
        }

        /// <summary>
        /// Read data from Cxls format
        /// </summary>
        /// <param name="dataValue">It cntains the values.</param>
        /// <returns>Product object</returns>
        public bool Create(DataSet ds, String themeDDLValue)
        {
            this.dataLoaderRepository.Create(ds, themeDDLValue);
            return true;
        }

        /// <summary>
        /// Get List of All data from Content_Government
        /// </summary>
        /// <returns>list of content_government</returns>
        public IEnumerable<Record> GetAll()
        {
            var questions = dataLoaderRepository.GetAll();
            List<Record> listRecord = new List<Record>();
            foreach (var item in questions)
            {
                Record objRecord = new Record
                {

                    Question = item.Question,
                    Level = item.Level,
                    Theme = item.Theme,
                    Answers = new Answers
                    {

                        OptionA = item.OptionA,
                        OptionB = item.OptionB,
                        OptionC = item.OptionC,
                        correctAns = item.Answer
                    }
                };
                listRecord.Add(objRecord);
            }
            return listRecord;
        }

        /// <summary>
        /// Initialized go object
        /// </summary>
        /// <param name="dataValue">It cntains the values.</param>
        /// <returns>Product object</returns>
        private QuestionAnswer InitializedContent_GovernmentObject(string[] dataValue)
        {
            QuestionAnswer obj = new QuestionAnswer();
            obj.QuestionNo = Convert.ToInt16(dataValue[0]);
            obj.Question = dataValue[1];
            obj.OptionA = dataValue[2];
            obj.OptionB = dataValue[3]; ;
            obj.OptionC = dataValue[4];
            obj.Answer = dataValue[5];
            obj.Level = dataValue[6];

            return obj;
        }

    }
}
