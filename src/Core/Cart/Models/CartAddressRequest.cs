namespace Core.Cart.Models;

public class CartAddressRequest
{
    /// <example>Nome do remetente</example>
    public string Name { get; set; }

    /// <example>18997542891</example>
    public string Phone { get; set; }

    /// <example>contato@melhorenvio.com.br</example>
    public string Email { get; set; }

    /// <example>16571478358</example>
    public string Document { get; set; }

    /// <example>89794131000100</example>
    public string CompanyDocument { get; set; }

    /// <example>SP</example>
    public string StateRegister { get; set; }

    /// <example>Endereço</example>
    public string Address { get; set; }

    /// <example>Complemento</example>
    public string Complement { get; set; }

    /// <example>1</example>
    public string Number { get; set; }

    /// <example>Bairro</example>
    public string District { get; set; }

    /// <example>São Paulo</example>
    public string City { get; set; }

    /// <example>BR</example>
    public string CountryId { get; set; }

    /// <example>19210000</example>
    public string PostalCode { get; set; }

    /// <example>Observação</example>
    public string Note { get; set; }
}