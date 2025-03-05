using System;

namespace LoggerSystem
{
    
    public interface ILogger
    {
        void Log(string message);
    }

    
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[FileLogger] {message}");
        }
    }

    
    public abstract class LoggerDecorator : ILogger
    {
        protected ILogger _logger;

        public LoggerDecorator(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void Log(string message)
        {
            _logger.Log(message);
        }
    }

    public class TimestampLogger : LoggerDecorator
    {
        public TimestampLogger(ILogger logger) : base(logger) { }

        public override void Log(string message)
        {
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            base.Log($"[{timestamp}] {message}");
        }
    }

    
    public class ErrorCategoryLogger : LoggerDecorator
    {
        private string _category;

        public ErrorCategoryLogger(ILogger logger, string category) : base(logger)
        {
            _category = category;
        }

        public override void Log(string message)
        {
            base.Log($"[{_category}] {message}");
        }
    }
}
