<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>PIZZERIA BELISSIMA 🍕 🍕 🍕</title>

</head>
<body style="background-color: lightgoldenrodyellow; color: black;"font-family:'Courier New'">
           

    <form id="form2" runat="server">
        <div>
            
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Text="Select a pizza" Value="0" />
                <asp:ListItem Text="Margherita" Value="8.99" />
                <asp:ListItem Text="Pepperoni" Value="10.99" />
                <asp:ListItem Text="Indian masala" Value="13.99" />
                <asp:ListItem Text="BBQ Chicken" Value="12.99" />
                <asp:ListItem Text="Veggie" Value="9.99" />
                <asp:ListItem Text="Tuna" Value="11.49" />
                
            </asp:DropDownList>
            
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price: $0.00"></asp:Label>
            
            <br />
            <br />
             <img 
                    src="https://img.freepik.com/premium-photo/expressive-emoticon-face-pizza-emoji_860905-3949.jpg" 
                    alt="Expressive emoticon face pizza emoji | Premium AI-generated image" 
                    style="float: right; margin-left: 15px; max-width: 800px; border-radius: 50%;" 
                />
           </div>
        <h3> EXTRA TOPPINGS</h3>
        <p>
             <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
             <asp:ListItem Text="Extra Cheese" Value="1.00" />
             <asp:ListItem Text="Mushroom" Value="0.75" />
             <asp:ListItem Text="Onion" Value="0.50" />
             <asp:ListItem Text="Fresh Garlic" Value="0.80" />
             <asp:ListItem Text="Green Olives" Value="0.90" />
             <asp:ListItem Text="Black Olives" Value="0.90" />
             <asp:ListItem Text="Sausage" Value="1.50" />
             <asp:ListItem Text="Green Pepper" Value="0.60" />
             <asp:ListItem Text="Mozzarella Cheese" Value="1.20" />
             <asp:ListItem Text="Salami" Value="1.30" />
             <asp:ListItem Text="Pepperoni" Value="1.40" />
            </asp:CheckBoxList>
                   
        </p>
        
        <asp:Label ID="Label1" runat="server" Text="Label1" Visible="False"></asp:Label>


        <div class="align-left">
            <asp:TextBox ID="txtCoupon" runat="server" placeholder="Enter Coupon Code"></asp:TextBox>
            <asp:RegularExpressionValidator 
                ID="regexCouponValidator" 
                runat="server" 
                ControlToValidate="txtCoupon" 
                ErrorMessage="Invalid coupon code.Use our End of Year discount: SAVE20." 
                ValidationExpression="^[A-Z0-9]{5,10}$" 
                ForeColor="Red">
    
            </asp:RegularExpressionValidator>
            <asp:Button ID="btnSubmit" runat="server" Text="Validate" OnClick="btnSubmit_Click" />
            <asp:Label ID="lblResult" runat="server" ForeColor="Green"></asp:Label>

        </div>
       
    </form>
</body>
</html>
