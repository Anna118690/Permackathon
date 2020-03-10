﻿using Microsoft.EntityFrameworkCore;
using Permackathon.Common.IssuesManager.Interfaces.IRepositories;
using Permackathon.Common.IssuesManager.Interfaces.UseCases;
using Permackathon.Common.IssuesManager.TransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Permackathon.Issues.BLL.UseCases
{
    public class User : IUser
    {

        //CTOR
        private readonly IIssuesUnitOfWork unitOfWork;

        public User(IIssuesUnitOfWork iIssuesUnitOfWork)
        {
            this.unitOfWork = iIssuesUnitOfWork ?? throw new System.ArgumentNullException(nameof(iIssuesUnitOfWork));
        }

        //Implementing Methods
        public IssueTO AddIssue(IssueTO Issue)
            => unitOfWork.IssuesRepository.Add(Issue);

        //public bool BecomeResolver(int id)
        //{
        //    unitOfWork.IssuesRepository.GetById(id);

 


        //}

        

        public bool BecomeResolver(int IssueId, int UserId)
        {
            var toUpdate = unitOfWork.IssuesRepository.GetById(IssueId);
            UserTO user = unitOfWork.UserRepository.GetById(UserId);
            //TODO
            //toUpdate.Resolver = user; 
            //var update = unitOfWork.IssuesRepository.Update(toUpdate);
            return true;
        }

        public IEnumerable<IssueTO> GetIssues()
            => unitOfWork.IssuesRepository.GetAll();

        public bool MarkAsArchived(int id)
        {
            throw new NotImplementedException();
        }

        public bool MarkAsArchived(int IssueId, int UserId)
        {
            throw new NotImplementedException();
        }

        //public bool MarkAsCompleted(int id)
        //{
            //var getIssue = unitOfWork.IssuesRepository.GetById(id);
            //var UpdateIssue = unitOfWork.IssuesRepository.Update(id);
            //if (getIssue.IsCompleted)
            //{
            //    return true;

            //}
            //return false;

        //}
        public bool MarkAsCompleted(int IssueId, int UserId)
        {
            var getIssue = unitOfWork.IssuesRepository.GetById(IssueId);
            UserTO user = unitOfWork.UserRepository.GetById(UserId);
            if (getIssue.IsCompleted)
            {
                return true;

            }
            return false;
        }
    }
}
