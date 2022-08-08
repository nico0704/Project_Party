﻿using Project_Party.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Party.Services
{
    public class MockDataStore : IDataStore<Party>
    {
        readonly List<Party> partys;

        public MockDataStore()
        {
            partys = new List<Party>()
            {
                new Party { Id = Guid.NewGuid().ToString(), Name = "First item", Description="This is an item description.", PictureName="TestFlyer.jpg", Time=DateTime.Now, City="Fulda", Adress="LeipzigerStraße 21", LocationName="Sclub" },
                new Party { Id = Guid.NewGuid().ToString(), Name = "Second item", Description="This is an item description.", PictureName="TestFlyer.jpg", Time=DateTime.Now, City="Fulda", Adress="LeipzigerStraße 21", LocationName="Sclub"  },
                new Party { Id = Guid.NewGuid().ToString(), Name = "Third item", Description="This is an item description.", PictureName="TestFlyer.jpg", Time=DateTime.Now, City="Fulda", Adress="LeipzigerStraße 21", LocationName="Sclub"  }
            };
        }

        public async Task<bool> AddItemAsync(Party item)
        {
            partys.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Party item)
        {
            var oldItem = partys.Where((Party arg) => arg.Id == item.Id).FirstOrDefault();
            partys.Remove(oldItem);
            partys.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = partys.Where((Party arg) => arg.Id == id).FirstOrDefault();
            partys.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Party> GetItemAsync(string id)
        {
            return await Task.FromResult(partys.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Party>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(partys);
        }
    }
}