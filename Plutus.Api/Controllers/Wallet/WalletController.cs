using Microsoft.AspNetCore.Mvc;

namespace Plutus.Api.Controllers.Wallet;

public class WalletController : PlutusControllerBaseV1
{
    [HttpGet]
    public string GetWallet()
    {
        return "sss";
    }
}