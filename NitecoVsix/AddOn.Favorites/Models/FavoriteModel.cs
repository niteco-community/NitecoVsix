using System;
using EPiServer.Data.Dynamic;

namespace $safeprojectname$.Models
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