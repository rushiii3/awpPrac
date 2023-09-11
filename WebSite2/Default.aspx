<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>
  <%@ Register TagPrefix="apress" TagName="Footer" Src="Footer.ascx" %>
  <%@ Register TagPrefix="apress1" TagName="UserControl" Src="~/UserControl.ascx" %>
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
<asp:AdRotator ID="AdRotator1"  runat = "server" AdvertisementFile = "Advert.xml"  
        Target =  "_blank" Height="200px" />
        
       <asp:AdRotator ID="AdRotator2"  runat = "server" AdvertisementFile = "Advert.xml"  
        Target =  "_blank" Height="200px" />
        <asp:AdRotator ID="AdRotator3"  runat = "server" AdvertisementFile = "Advert.xml"  
        Target =  "_blank" Height="200px" />
   <asp:Panel runat=server BackColor=Beige>
    <apress:Footer ID="Footer1" runat=server />
    <apress1:UserControl runat=server />
        <p align="center" 
            style="font-family: Roman; font-size: xx-large; font-variant: normal; font-style: normal; font-weight: normal; text-decoration: blink;" >
            Register
        </p>
        <p align="center">
        &nbsp &nbsp &nbsp &nbsp &nbsp &nbsp
             <asp:Label runat=server Font-Size="Large">EMAIL</asp:Label> &nbsp &nbsp &nbsp
            <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Email" 
                 Columns="40" ToolTip="Email" Height="30px" Rows="20" 
                TabIndex="1" Font-Size=Small ></asp:TextBox>
                <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                ErrorMessage="Please Enter Your Email" ControlToValidate="TextBox1" 
                Font-Bold="True" Font-Names="Bahnschrift" 
                Font-Size="Small" Font-Underline="True" ForeColor="Red" 
                EnableTheming="True"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator
                    ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox1"
                ErrorMessage="Your email should contain @gmail.com" Font-Bold="True" 
                Font-Names="Bell MT" Font-Size=Small ForeColor="#FF3399" 
                ValidationExpression=".+@.+" Display="Dynamic" SetFocusOnError="True"></asp:RegularExpressionValidator>
                <br />  
        </p>
        <p align="center">
            <asp:Label ID="Label1" runat=server Font-Size="Large">PASSWORD</asp:Label> &nbsp &nbsp &nbsp
            <asp:TextBox ID="TextBox2" runat="server"
                 Columns="40" ToolTip="Password" Height="30px" Rows="20" 
                TabIndex="2" Font-Size=Small TextMode="Password">
             </asp:TextBox>
             <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                ErrorMessage="Please Enter Your password" ControlToValidate="TextBox2" 
                SetFocusOnError="True" Font-Bold="True" Font-Names="Bahnschrift" 
                Font-Size="Small" Font-Underline="True" ForeColor="Red"></asp:RequiredFieldValidator>
            
        </p>
        <p align="center">
            <asp:Label ID="Label2" runat=server Font-Size="Large">Re-PASSWORD</asp:Label> &nbsp 
            <asp:TextBox ID="TextBox3" runat="server"
                Columns="40" ToolTip="Password" Height="30px" Rows="20" 
                TabIndex="2" Font-Size="Large" TextMode="Password" ControlToValidate="TextBox3">
             </asp:TextBox>
             <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                ErrorMessage="Please Enter Your Current Password" ControlToValidate="TextBox3" 
                SetFocusOnError="True" Font-Bold="True" Font-Names="Bahnschrift" 
                Font-Size=Small Font-Underline="True" ForeColor="Red"></asp:RequiredFieldValidator>
            
            <asp:CompareValidator ControlToValidate="TextBox3" ID="CompareValidator1" runat="server" ErrorMessage="Your password should match with retype password" ValueToCompare="TextBox2"></asp:CompareValidator>
                
        </p>
        <p align="center">
            <asp:Label ID="Label3" runat=server Font-Size="Large">Pincode</asp:Label> &nbsp 
            <asp:TextBox ID="TextBox4" runat="server"
                Columns="40" ToolTip="Pincode" Height="30px" Rows="20" 
                TabIndex="2" Font-Size="Large" TextMode="Number" 
                ControlToValidate="TextBox4"></asp:TextBox>
             <br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                ErrorMessage="Please Enter Your Pincode" ControlToValidate="TextBox4" 
                SetFocusOnError="True" Font-Bold="True" Font-Names="Bahnschrift" 
                Font-Size=Small Font-Underline="True" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:CustomValidator ID="CustomValidator1"  runat="server" 
                OnServerValidate="UserCustomValidate" ErrorMessage="Enter a Valid Pincode" 
                ControlToValidate="TextBox4" Font-Bold="True" ForeColor="Red"></asp:CustomValidator>
            
        </p>
       
        <p align=center>
            
            <asp:Button ID="Button1" runat="server" Text="Submit" BackColor="#0066FF" 
                BorderColor="#000066" Font-Bold="True" Font-Names="Arial Black" 
                Font-Size="Medium" ForeColor="White" ToolTip="Submit" NavigateUrl="~/About.aspx"
                 />
   
        </p>

      <script type="text/javascript">
        
      </script>
        <p>
        <asp:Image ID="Image2" runat="server" Height="359px" 
            ImageUrl="https://www.pixelstalk.net/wp-content/uploads/2016/07/Wallpapers-pexels-photo.jpg" 
            Width="918px" />
            
        </p>
        
        <br />
   </asp:Panel>
</asp:Content>
