WebServices.VBNET
====================

VS 2013 Express application that processes transactions to our web services platform.  This example allows you to modify the webservices URL and the SOAPAction.  You can then open an xml file (a sample is included in the ExampleXML folder named:  E2E_CreditSale.xml) and press the 'Process Txn' button.  This will POST the loaded xml to the webservices URL using the soap action specified.

3 step process to integrate to Mercury Web Services.

##Step 1: Build Soap Envelope

There is an example xml file in the ExampleXML folder named:  E2E_CreditSale.xml.
  
```
<soapenv:Envelope xmlns:soapenv="http://schemas.xmlsoap.org/soap/envelope/" xmlns:mer="http://www.mercurypay.com">
<soapenv:Header/>
<soapenv:Body>
<mer:CreditTransaction>
<mer:tran xmlns="http://www.mercurypay.com">
<![CDATA[<TStream> 
<Transaction> 
<MerchantID>019588466313922</MerchantID> 
<TranType>Credit</TranType> 
<TranCode>Sale</TranCode> 
<InvoiceNo>21</InvoiceNo> 
<RefNo>21</RefNo> 
<Memo>Brian VB.NET WS Project</Memo> 
<Frequency>OneTime</Frequency> 
<RecordNo>RecordNumberRequested</RecordNo> 
<PartialAuth>Allow</PartialAuth> 
<Account><EncryptedFormat>MagneSafe</EncryptedFormat> 
<AccountSource>Swiped</AccountSource> 
<EncryptedBlock>2F8248964608156B2B1745287B44CA90A349905F905514ABE3979D7957F13804705684B1C9D5641C</EncryptedBlock> 
<EncryptedKey>9500030000040C200026</EncryptedKey> 
</Account> 
<Amount> 
<Purchase>10.00</Purchase> 
</Amount> </Transaction> 
</TStream>]]>
</mer:tran>
<mer:pw>xyz</mer:pw>
</mer:CreditTransaction>
</soapenv:Body>
</soapenv:Envelope>

```
  
##Step 2: Process the Transaction (this code shows a direct POST)

a. Create a WebRequest object pointed at the testing URL @ https://w1.mercurydev.net/ws/ws.asmx.

b. Make sure to set the SOAPAction header to the correct SOAPAction

c. Write the data to the request's stream

```
  Dim request As HttpWebRequest = DirectCast(WebRequest.Create(New Uri(uriString)), HttpWebRequest)
  request.Credentials = CredentialCache.DefaultCredentials
  request.Method = "POST"
  request.ContentType = "text/xml; charset=utf-8"
  request.Headers.Add([String].Format("SOAPAction: ""{0}""", soapAction))
  request.ContentLength = buffer.Length
  request.ReadWriteTimeout = 10
  request.ProtocolVersion = HttpVersion.Version11
  
  Dim newStream As Stream = request.GetRequestStream()
  newStream.Write(buffer, 0, buffer.Length)
  newStream.Close()
```

##Step 3: Wait for the response and then parse the response


```
  Dim response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)
  Dim receiveStream As Stream = response.GetResponseStream()
  Dim readStream As New StreamReader(receiveStream, Encoding.UTF8)
  Dim responseData As String = readStream.ReadToEnd()
  
```

###©2014 Mercury Payment Systems, LLC - all rights reserved.

Disclaimer:
This software and all specifications and documentation contained herein or provided to you hereunder (the "Software") are provided free of charge strictly on an "AS IS" basis. No representations or warranties are expressed or implied, including, but not limited to, warranties of suitability, quality, merchantability, or fitness for a particular purpose (irrespective of any course of dealing, custom or usage of trade), and all such warranties are expressly and specifically disclaimed. Mercury Payment Systems shall have no liability or responsibility to you nor any other person or entity with respect to any liability, loss, or damage, including lost profits whether foreseeable or not, or other obligation for any cause whatsoever, caused or alleged to be caused directly or indirectly by the Software. Use of the Software signifies agreement with this disclaimer notice.

