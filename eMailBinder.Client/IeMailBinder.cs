using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eMailBinder.Core.Common;

namespace eMailBinder.Client;
public interface IeMailBinder
{
    StatusInfo<string> SubscribeToList(int listId);
    
}