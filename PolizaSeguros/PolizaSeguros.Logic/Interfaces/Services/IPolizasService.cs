namespace PolizaSeguros.Logic.Interfaces.Services
{
	using PolizaSeguros.Model.DTO;
	using PolizaSeguros.Model.Model;

	public interface IPolizasService
	{
		GenericResponseDTO Create(Poliza data);
		GenericResponseDTO Update(Poliza data);
		GenericResponseDTO Delete(Poliza data);
	}
}
