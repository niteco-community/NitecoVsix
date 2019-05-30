using System;
using EPiServer.Data.Dynamic;

namespace $projectname$.Models
{
    [EPiServerDataStore(AutomaticallyCreateStore = true)]
    public class FavoriteModel
    {
        public Guid Id { get; set; }

        [EPiServerDataIndex]
        public string UserName { get; set; }

        [EPiServerDataIndex]
        public string ContentLink { get; set; }
    }
}