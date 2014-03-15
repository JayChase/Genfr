#Genfr

A generic repository with a fluent interface to provide a flexible query API. This allows the benefits of being able to build queries through method chaining without having to return IQueryable from the repository.

##Getting started

Create a new instance of Store passing in a DbContext to the constructor. Use the Query<T> method to return the QueryBuilder for the desired entity. From then on in the API should be familiar to Entity Framework users.

```c#
using (var store = new Store(new mContext(connectionString)))
{                
    var result = await store.Query<Entity>()
                                .Include(e => e.NavProp)
                                .OrderBy(e => e.Name)
                                .Where(e => e.Price == 9.99M)
                                .ToListAsync();
}
```
The usual create, update and delete functioniality is provided as well.

##Overview

* __Genfr.Repository__

    Contains the interfaces:
    IStore (the repository)
    IQueryBuilder and IOrderedQueryBuilder (the fluent interfaces for building queries)

* __Genfr.EntityFramework__

    A concrete implementation of Genfr for EntityFramework.


