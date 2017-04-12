# 参考链接
https://www.devart.com/dotconnect/postgresql/docs/EFCore-Database-First.html

## 使用说明
使用Nuget,引用以下包

Install-Package Microsoft.EntityFrameworkCore.Tools
Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design

## 在Nuget包管理器控制台执行下面命令,生成指定数据库下所有表的实体类

Scaffold-DbContext  "Data Source=.;Initial Catalog=OnlineFruit_Upgrade_V2;User ID=sa;Password=Sa123456" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

## 在Nuget包管理器控制台执行下面命令(增加参数 -Tables Shop,ProductLibrary),生成指定数据库下指定表(Shop,ProductLibrary)的实体类

Scaffold-DbContext "Server=.;Database=OnlineFruit_Upgrade_V2;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -Tables Shop,ProductLibrary -OutputDir Models

## 控制台程序输出有乱码，解决方法：
### 第一步：引用 System.Text.Encoding.CodePages

Install-Package System.Text.Encoding.CodePages

### 第二步：输出前增加以下代码

System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Console.WriteLine(System.Text.Encoding.GetEncoding("GB2312"));


