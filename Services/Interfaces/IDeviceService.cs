using System.Threading.Tasks;
using JammerV1.Models;
using SharpPcap;

public interface IDeviceService {
    IInjectionDevice CaptureDevice { get; }
    Task<bool> IsDeviceInMonitorMode(string deviceName);
    Task<bool> SetMonitorMode(string deviceName);
    Task OpenDevice();
    Task JamClient(Client client);
    Task JamAP(AP ap);
    Task Scan(int secondsToRun);
}