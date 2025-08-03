using CsBases.Fundamentos;

public class ProductRepository
{
    public async Task<Product> GetProduct(int id)
    {
        // Obtener de una bd
        //  una llamada a una API externa 
        // Podria ser de un archivo
        WriteLine("Buscando producto...");
        await Task.Delay(2000);
        return new Product("Product simulado", 500);
    }
}