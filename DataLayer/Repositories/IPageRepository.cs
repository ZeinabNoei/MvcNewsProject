using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   public interface IPageRepository: IDisposable
    {
        IEnumerable<Page> GetAllPage();
        Page GetPageById(int pageId);
        bool InsertPage(Page page);
        bool UpdatePage(Page page);
        bool DeletePage(Page page);
        bool DeletePage(int pageId);
        void Save();
       IQueryable<Page> Get(Expression<Func<Page, bool>> predicate);
        IEnumerable<Page> TopNews(int take = 4);
        IEnumerable<Page> pagesInSlider();
        IEnumerable<Page> LastNews(int take = 4);
        IEnumerable<Page> ShowPageByGroupId(int groupId);
        IEnumerable<Page> SearchPage(string search);
    }
}
