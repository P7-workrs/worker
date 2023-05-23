using Xunit;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text.Json;
using System.Reflection;
using FluentFTP;
using Newtonsoft.Json.Linq;
using Serilog;
using System.Text;
using System.Threading;
using p7Worker;
using Moq;
using p7Worker.RabbitMQ;
using p7Worker.ContainerHandling.Logic;
using p7Worker.Filehandler;
using p7Worker.DTOs;

namespace p7WorkerTest;

public class WorkerTests
{
    Worker _sut;
    private readonly Mock<RabbitMQHandler> _rabbitMQHandlerMock;
    private readonly Mock<LinuxContainerController> _containerControllerMock;
    private readonly Mock<FileOperationsLinux> _fileOperationsMock;

    ILogger _logger = Log.Logger = new LoggerConfiguration()
     .MinimumLevel.Debug()
     .WriteTo.Console()
     .WriteTo.File($"logs/p7-{WorkerInfoDto.WorkerId}-log.txt", rollingInterval: RollingInterval.Day)
     .CreateLogger();
    public WorkerTests()
    {
        _rabbitMQHandlerMock = new Mock<RabbitMQHandler>();
        _containerControllerMock = new Mock<LinuxContainerController>();
        _fileOperationsMock = new Mock<FileOperationsLinux>();
        //_sut = new Worker(_rabbitMQHandlerMock.Object, _containerControllerMock.Object, _fileOperationsMock.Object, _logger);
    }
    public void CreateAndExecuteContainerAsync_situation_expectedOutcome()
    {
        //arrange
        //_containerControllerMock.Setup(x => x.CreateContainerAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.CompletedTask);

        //act
        //_sut.CreateAndExecuteContainerAsync("").RunSynchronously();

        //assert
    }
}
