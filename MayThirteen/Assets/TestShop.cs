using UnityEngine;
using System.Collections;
using UnityEngine.Purchasing.Extension;
using System.Collections.Generic;
using UnityEngine.Purchasing;
using System.Collections.ObjectModel;
using System;
using UnityEngine.UI;

public class TestShop : IStore
{
    public Text DebugText;
    public const string Name = "samplestore";
    private IStoreCallback m_Biller;
    private List<string> m_PurchasedProducts = new List<string>();

    public void Initialize(IStoreCallback biller)
    {
        m_Biller = biller;
    }

    public void RetrieveProducts(ReadOnlyCollection<ProductDefinition> productDefinitions)
    {
        Debug.Log("RetrieveProducts");
        var products = new List<ProductDescription>();
        foreach (var product in productDefinitions)
        {
            var metadata = new ProductMetadata("$123.45", "Fake title for " + product.id, "Fake description", "USD", 123.45m);
            products.Add(new ProductDescription(product.storeSpecificId, metadata));
        }
        m_Biller.OnProductsRetrieved(products);
    }

    public void Purchase(ProductDefinition product, string developerPayload)
    {
        // Keep track of non consumables.
        if (product.type != ProductType.Consumable)
        {
            m_PurchasedProducts.Add(product.storeSpecificId);
        }
        m_Biller.OnPurchaseSucceeded(product.storeSpecificId, "{ \"this\" : \"is a fake receipt\" }", Guid.NewGuid().ToString());
    }

    public void FinishTransaction(ProductDefinition product, string transactionId)
    {
    }
}
