using Newtonsoft.Json;

namespace Project.CoreMVC.Models.ShoppingTools
{
    [Serializable]
    public class Cart
    {
        [JsonProperty("_myCart")]
        Dictionary<int,CartItem> _myCart;

        public Cart()
        {
            _myCart = new Dictionary<int,CartItem>();   

            // _myCart[1] normal şartlar altıında index parantezleri ilgili index'teki elemanı seçme ifadesini söyler fakat bir Dictionart koleksiyonu söz konusu olduğunda bir index parantezi ilgili key'e sahip anahtarı seç demektir.
        }
        [JsonProperty("GetCartItems")]
        public List<CartItem> GetCartItems
        {
            get
            {
                return _myCart.Values.ToList();
            }
        }

        public void AddToCart(CartItem ci)
        {
            if (_myCart.ContainsKey(ci.ID))
            {
                _myCart[ci.ID].Amount++;
                return;
            }
            _myCart.Add(ci.ID, ci); 
        }

        public void Decrease(int id)
        {
            _myCart[id].Amount--;
            if (_myCart[id].Amount == 0) _myCart.Remove(id); // Dictionary'deki remove metodu verdiğimiz anahtardaki veriyi siler.
        }

        public void RemoveFromCart(int id)
        {
            _myCart.Remove(id);
        }

        [JsonProperty("TotatPrice")]
        public decimal TotalPrice
        {
            get
            {
                return _myCart.Values.Sum(x => x.SubTotal);
            }
        }

    }
}
