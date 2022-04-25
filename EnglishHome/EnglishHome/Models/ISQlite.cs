using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace EnglishHome.Models
{
     public interface ISQlite
    {
        SQLiteConnection GetConnection();
    }
}
