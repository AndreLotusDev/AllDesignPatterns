namespace SerializationCopy.Interfaces
{
    public interface IDeepCopy<T> where T : new ()
    {
		void CopyTo(T objetoAlvo);

		public T DeepCopy()
		{
			T t = new T();
			CopyTo(t);
			return t;
		}
	}
}
