using System;

namespace Observer {
	
	public class ConcreteObserver : IObserver {
		
		private readonly ConcreteSubject _subject;
        private readonly string ObserverName;

		public ConcreteObserver(string ObserverName, ConcreteSubject subject) {
			this._subject = subject;
            this.ObserverName = ObserverName;
		}

		public void Update() {
			Console.WriteLine("{0}: subject state updated to {1} .", this.ObserverName, this._subject.State);
		}
	}
}