using System.Collections;
using Cysharp.Threading.Tasks;
using UnityEngine.TestTools;

public class KmdClientTest : KmdClientTestFixture
{
    protected override async UniTask SetUpAsync()
    {
        await base.CheckServices();
    }

    protected override UniTask TearDownAsync()
    {
        return UniTask.CompletedTask;
    }

    [UnityTest]
    public IEnumerator GetSwaggerSpecShouldReturnOkay() => UniTask.ToCoroutine(async () =>
    {
        var response = await kmd.GetSwaggerSpec();
        AssertResponseSuccess(response);
    });

    [UnityTest]
    public IEnumerator GetVersionsShouldReturnOkay() => UniTask.ToCoroutine(async () =>
    {
        var response = await kmd.Versions();
        AssertResponseSuccess(response);
    });
}