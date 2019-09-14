# WCFHotelOpService

Its a simple WCF service that's using HTTP as default binding

Http Binding used is as follows

```xml
<system.serviceModel>
    <services>
      <service behaviorConfiguration="Default" name="HotelOpService.HotelService">
        <endpoint address="" behaviorConfiguration="webBehavior" binding="webHttpBinding"
          contract="HotelOpService.IHotelService" />
        <host>
          <baseAddresses>
            <add baseAddress="http://localhost:6060/Hotel" />
          </baseAddresses>
        </host>
      </service>
    </services>
    <behaviors>
      <endpointBehaviors>
        <behavior name="webBehavior">
          <webHttp />
        </behavior>
      </endpointBehaviors>
      <serviceBehaviors>
        <behavior name="Default">
          <serviceMetadata httpGetEnabled="true" />
        </behavior>
      </serviceBehaviors>
    </behaviors>
  </system.serviceModel>
```
