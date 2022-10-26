# 第6次練習-練習-PC6
>
>學號：109111134 
><br />
>姓名：林禹廷 
><br />
>作業撰寫時間：3 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/10/12
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容

開始寫說明，該說明需說明想法，
並於之後再對上述想法的每一部分將程式進一步進行展現，
若需引用程式區則使用下面方法，
若為.cs檔內程式除了於敘述中需註明檔案名稱外，
還需使用語法` ```csharp 程式碼 ``` `，
下段程式碼則為使用後結果：

```csharp
public partial class Test :...
    {
        string[] sa = new string[] { "台科", "北科", "亞東"};
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int a_i = 0; a_i < sa.Length; a_i ++)
            {
                ListItem l_t = new ListItem();
                l_t.Text = l_t.Value = sa[a_i];
                //Response.Write(l_t.Text + "<br>" + l_t.Value + "<br>");
                ddl_Test.Items.Add(l_t);
            }
        }
    }
```

若要於內文中標示部分.aspx檔，則使用以下標籤` ```html 程式碼 ``` `，
下段程式碼則為使用後結果：

```html
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="_111_1PC6.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_Test" runat="server"></asp:DropDownList>
        </div>
    </form>
</body>
</html>
```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

此題需先知道下拉是選單為DropDownList，並於創建後修改其id，然後知道全域與區域的差異，此題沒差，但後續延伸引用時，全域會較好一些，並用listItem去存取Text and Value，在一次性的add到選單中即可。
