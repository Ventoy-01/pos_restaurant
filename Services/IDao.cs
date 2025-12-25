namespace Pos_Restaurant.Services;

public interface IDao<T>
{
		void Save(T s);
		
		void Update(T s);
		
		void Delete(String id);
		
		T Details (String s);
	
		List<T> Display();
    
}