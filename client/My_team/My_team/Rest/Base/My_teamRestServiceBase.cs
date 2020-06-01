using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using My_team.Models;
using Newtonsoft.Json;

namespace My_team.Rest.Base
{
    public class My_teamRestServiceBase : RestClient
    {
        const string My_teamApi = "my_team/";
    }
}
