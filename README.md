# aist-chr-ext
Chrome Extension: Frontend and backend (API) to store web pages data

1. To run this chrome extension follow this:

Source: https://developer.chrome.com/extensions/getstarted

Load the extension
Extensions that you download from the Chrome Web Store are packaged up as .crx files, which is great for distribution, but not so great for development. Recognizing this, Chrome gives you a quick way of loading up your working directory for testing. Let's do that now.

Visit chrome://extensions in your browser (or open up the Chrome menu by clicking the icon to the far right of the Omnibox:  The menu's icon is three horizontal bars. and select Extensions under the More Tools menu to get to the same place).

Ensure that the Developer mode checkbox in the top right-hand corner is checked.

Click Load unpacked extension… to pop up a file-selection dialog.

Navigate to the directory in which your extension files live, and select it.

Alternatively, you can drag and drop the directory where your extension files live onto chrome://extensions in your browser to load it.

If the extension is valid, it'll be loaded up and active right away! If it's invalid, an error message will be displayed at the top of the page. Correct the error, and try again.

2. To run the API you have to create:
- Create the "AISTDB" database and add the table schema:

USE [AISTDB]
GO

/****** Object:  Table [dbo].[PagesData]    Script Date: 11/12/2017 5:14:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PagesData](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Url] [nvarchar](max) NULL,
	[HtmlString] [nvarchar](max) NULL,
	[PageType] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.PagesDatas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

- Update the connection string to point to your SQL server.
