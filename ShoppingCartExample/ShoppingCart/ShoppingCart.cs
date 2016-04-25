using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public abstract class ShoppingCart<T>
{
    private List<T> allEntities;
    private HttpContextBase context;

    public ShoppingCart(HttpContextBase context)
    {
        this.context = context;

        if (this.context.Session["ShoppingCart"] != null)
        {
            allEntities = this.context.Session["ShoppingCart"] as List<T>;
        }
        else
        {
            allEntities = new List<T>();
        }
    }

    private void RefreshSession()
    {
        this.context.Session["ShoppingCart"] = allEntities;
    }

    public List<T> GetAll()
    {
        return allEntities;
    }

    public void Add(T entity)
    {
        allEntities.Add(entity);
        RefreshSession();
    }

    public void Remove(T entity)
    {
        allEntities.Remove(entity);
        RefreshSession();
    }

    public void Clear()
    {
        allEntities.Clear();
        RefreshSession();
    }
}