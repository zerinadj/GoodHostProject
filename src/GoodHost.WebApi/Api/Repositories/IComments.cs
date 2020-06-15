using GoodHost.Api.Models;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace GoodHost.Api.Repositories

{

    interface IComments

    {

        void InsertComment(Comment Comment); //Inserting

        IEnumerable<Comment> ListofComment(); //List of Comment

    }

}