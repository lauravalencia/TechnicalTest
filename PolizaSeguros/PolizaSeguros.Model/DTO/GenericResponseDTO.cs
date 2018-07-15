namespace PolizaSeguros.Model.DTO
{
	public class GenericResponseDTO
	{
		public bool OperationSuccess { get; set; }
		public string ErrorMessage { get; set; }
		public object ObjectResponse { get; set; }
	}
}
